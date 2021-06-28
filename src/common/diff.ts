import equal from "fast-deep-equal";

type DeepPartial<T> = {
  [P in keyof T]?: DeepPartial<T[P]>;
};

/* eslint-disable @typescript-eslint/no-unsafe-member-access, @typescript-eslint/no-explicit-any */
export const computeDelta = <T>(
  legacy: T,
  current: T,
): {
  modified: DeepPartial<T>;
  deleted: DeepPartial<T>;
} => {
  const modified: Record<string, unknown> = {};
  const deleted: Record<string, unknown> = {};

  for (const [key, lValue] of Object.entries(legacy)) {
    if (!(key in current)) {
      deleted[key] = lValue;
    }
  }
  for (const [key, cValue] of Object.entries(current)) {
    if (cValue === undefined || cValue === null) continue;
    if (equal(cValue, (legacy as any)[key])) continue;

    if (Array.isArray(cValue)) {
      modified[key] = cValue;
    } else if (typeof cValue === "object") {
      if (!(key in legacy) || Array.isArray((legacy as any)[key])) {
        // legacy does not have this key, or
        // current is Object, but legacy is Array
        modified[key] = cValue;
      } else if (typeof (legacy as any)[key] === "object") {
        // both current and legacy are Object
        const localDiff = computeDelta((legacy as any)[key], cValue);
        if (!equal(localDiff.modified, {})) modified[key] = localDiff.modified;
        if (!equal(localDiff.deleted, {})) deleted[key] = localDiff.deleted;
      } else {
        // current is Object, but legacy is not so
        modified[key] = cValue;
      }
    } else {
      modified[key] = cValue;
    }
  }
  return { modified, deleted } as {
    modified: Partial<T>;
    deleted: Partial<T>;
  };
};
/* eslint-enable @typescript-eslint/no-unsafe-member-access, @typescript-eslint/no-explicit-any */
