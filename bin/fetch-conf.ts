import { mkdir, writeFile } from "fs/promises";
import got from "got";
import { join } from "path";

const mkdirP = (path: string) => mkdir(path).catch(() => {});

const targetDir = join(__dirname, "..", "assets");

const clientConf = got.extend({
  prefixUrl: "https://ak-conf.hypergryph.com",
  headers: {
    Accept: "*/*",
    "User-Agent": "arknights/398 CFNetwork/1240.0.4 Darwin/20.5.0",
    "Accept-Language": "en-us",
    "Accept-Encoding": "gzip, deflate, br",
    "X-Unity-Version": "2017.4.39f1",
  },
});
const fetchConf = async (url: string, target?: string): Promise<void> => {
  const value = (await clientConf.get(url)).body;
  await writeFile(
    join(targetDir, "conf", target ?? url.substr(url.lastIndexOf("/"))),
    value,
  );
};

const main = async () => {
  await mkdirP(join(targetDir, "conf"));
  await Promise.all([
    fetchConf("config/prod/official/network_config"),
    fetchConf("config/prod/official/remote_config"),
    fetchConf("config/prod/official/IOS/version"),
  ]);
  console.log("conf fetched");
};

main()
  .then(() => process.exit())
  .catch(console.error);
