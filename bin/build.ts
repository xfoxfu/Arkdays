import { readFileSync, writeFileSync } from "fs";

if (process.argv.length <= 3) {
  console.log(`usage: ts-node ${process.argv[1]} dump.cs version`);
  process.exit(1);
}

const filePath = process.argv[2];

const data = JSON.parse(readFileSync(filePath).toString()) as IData;

type IData = IImage[];

interface IImage {
  name: string;
  classes: IClass[];
}

interface IClass {
  type: "enum" | "class" | "interface";
  name: string;
  parent?: string;
  interfaces: unknown[];
  fields: IField[];
  methods: unknown[];
}

interface IField {
  type: string;
  name: string;
  value: any;
}

type IExport = {
  name: string;
  fullName: string;
  klass: Record<string, IClass>;
  child: Record<string, IExport>;
};

const ret: IExport = { name: "", fullName: "", klass: {}, child: {} };

for (const image of data) {
  for (const klass of image.classes) {
    const route = klass.name.split(".");
    let visit = ret;
    for (const layer of route.slice(0, route.length - 1)) {
      if (visit.child[layer] === undefined) {
        visit.child[layer] = {
          name: layer,
          fullName: visit.fullName + "." + layer,
          klass: {},
          child: {},
        };
      }
      visit = visit.child[layer];
    }
    visit.klass[route[route.length - 1]] = klass;
  }
}

const write = (layer: IExport, indent = ""): string => {
  if (layer.name.startsWith("<") || layer.fullName.endsWith(".UI")) return "";
  let result = "";
  if (layer.fullName === ".HGSDK") layer.name = "HgSDK";
  result += indent + `export namespace ${layer.name} {\n`;
  for (const [name, klass] of Object.entries(layer.klass)) {
    if (name.startsWith("<")) continue;
    if (
      [
        "ObjectPtr",
        "EventPool",
        "KeyFrames",
        "LoopScrollAdapter",
        "RecycleLoopScrollAdapter",
        "UINotifyView",
        "RespListener",
        "DBComponent",
        "DataBinder",
        "DBComponent<T1,T2>",
        "DBComponent<T>",
        "KeyFrames<TData>",
      ].includes(name) ||
      [
        "Torappu.Building.GridMap.Options",
        "Torappu.UI.HandBook.HandBookGroupDetailEdit",
      ].includes(klass.name)
    )
      continue;
    if (klass.type !== "enum") {
      result += indent + `  export interface ${name} {\n`;
      for (const prop of klass.fields) {
        if (
          ["m_skills", "m_defaultSkillIndex", "m_skinId"].includes(prop.name)
        ) {
          prop.name = prop.name.replace("m_", "");
        }
        let comment = "";
        if (
          prop.name.includes("__Hotfix") ||
          prop.name.includes("<") ||
          prop.name.includes(">") ||
          prop.name.includes("$") ||
          prop.name.startsWith("m_") ||
          prop.name.startsWith("s_") ||
          prop.type.includes("ActionArray") ||
          prop.type.includes("ActionArray") ||
          prop.type.includes("ActionList") ||
          prop.type.includes("BitBenderGames") ||
          prop.type.includes("CodeStage") ||
          prop.type.includes("DG") ||
          prop.type.includes("EaseFunctions") ||
          prop.type.includes("FlipMode") ||
          prop.type.includes("LogSeverity") ||
          prop.type.includes("NonDrawingGraphic") ||
          prop.type.includes("OperaNodeArray") ||
          prop.type.includes("RenderHeads") ||
          prop.type.includes("SerializedTNodeData") ||
          prop.type.includes("SharpNeatLib") ||
          prop.type.includes("SoftMasking") ||
          prop.type.includes("Spine.Unity") ||
          prop.type.includes("System.Action") ||
          prop.type.includes("System.AsyncCallback") ||
          prop.type.includes("System.Collections.IEnumerator") ||
          prop.type.includes("System.Comparison") ||
          prop.type.includes("System.Diagnostics") ||
          prop.type.includes("System.Exception") ||
          prop.type.includes("System.Func") ||
          prop.type.includes("System.Globalization.CultureInfo") ||
          prop.type.includes("System.Reflection") ||
          prop.type.includes("System.Text.Encoding") ||
          prop.type.includes("System.Type") ||
          prop.type.includes("System.WeakReference") ||
          prop.type.includes("Torappu.DataBind.DataBinder") ||
          prop.type.includes(".UI.") ||
          prop.type.includes("Torappu.WaitForAsyncTask") ||
          prop.type.includes("UnityEngine") ||
          prop.type.includes("UniWebView")
        ) {
          comment = "// ";
        }
        if (["currentTmpl", "tmpl"].includes(prop.name)) comment = "// ";
        if (prop.type === "System.Text.RegularExpressions.Regex") {
          prop.type = "RegExp";
        }
        if (prop.type.startsWith("HGSDK.")) {
          prop.type = prop.type.replace("HGSDK.", "HgSDK.");
        }
        prop.type = prop.type.replace("<HGSDK.", "<HgSDK.");
        prop.type = prop.type.replace("[,]", "[][]");
        prop.type = prop.type.replace("[,,]", "[][][]");
        if (klass.name === "Torappu.PlayerDataModel") {
          if (prop.name === "events") prop.name = "event";
        }
        if (
          klass.name === "Torappu.CharacterData.MainSkill" &&
          prop.name === "specializeLevelUpData"
        ) {
          prop.name = "levelUpCostCond";
        }
        if (
          klass.name === "Torappu.PlayerDataModel" &&
          prop.name === "campaign"
        ) {
          prop.name = "campaignV2";
        }
        if (
          klass.name === "Torappu.PlayerCharacter" &&
          prop.name === "skinId"
        ) {
          prop.name = "skin";
        }
        if (
          klass.name === "Torappu.RequestSquadSlot" &&
          prop.name === "S_skillIndex"
        ) {
          prop.name = "skillIndex";
        }

        result += indent + `    ${comment}${prop.name}: ${prop.type};\n`;
      }
      result += indent + `  }\n`;
    } else {
      result += indent + `  export enum ${name} {\n`;
      let fieldId = 0;
      for (const prop of klass.fields) {
        if (prop.name === "value__") continue;
        if (
          [
            "Torappu.PreAnnounceData.PreAnnounceType",
            "Torappu.PlayerSyncModuleMask",
          ].includes(klass.name)
        ) {
          result += indent + `    ${prop.name} = ${prop.value},\n`;
        } else {
          result += indent + `    ${prop.name} = "${prop.name}",\n`;
        }
        fieldId += 1;
      }
      result += indent + `  }\n`;
    }
  }
  for (const sublayer of Object.values(layer.child)) {
    result += write(sublayer, indent + "  ");
  }
  result += indent + "}\n";
  return result;
};

writeFileSync(
  "src/types.ts",
  `/* eslint-disable */
/**
 * This file is generated by bin/build.ts.
 *
 * DO NOT MANUALLY EDIT ANY CONTENT. IF THIS FILE DOES NOT FIT NEEDS, EDIT bin/build.ts TO FIX IT.
 *
 * @version ${process.argv[3]}
 */
export namespace System {
  export type AsyncCallback = void;
  export type Boolean = boolean;
  export type Byte = number;
  export type Char = string;
  export type DateTime = Date;
  export type Decimal = number;
  export type Double = number;
  export type Int16 = number;
  export type Int32 = number;
  export type Int64 = number;
  export type Nullable<T> = T | null;
  export type Undefinable<T> = T | undefined;
  export type Object = unknown;
  export type SByte = number;
  export type Single = number;
  export type String = string;
  export type UInt32 = number;
  export type UInt64 = number;
  export namespace Collections {
      export namespace Generic {
          export type List<T> = Array<T>;
          export type IList<T> = Array<T>;
          export type Queue<T> = Array<T>;
          export type HashSet<T> = Set<T>;
          export type Dictionary<K extends string | number, V> = Record<K, V>;
          export type IDictionary<K extends string | number, V> = Record<K, V>;
          export type KeyValuePair<K extends string | number, V> = Record<K, V>;
      }
  }
}
export namespace Newtonsoft {
  export namespace Json {
    export namespace Linq {
      export type JObject = any;
    }
  }
}
` +
    write(ret.child["Torappu"]) +
    write(ret.child["U8"]) +
    write(ret.child["HGSDK"]),
);
