import equal from "fast-deep-equal";

export const computeDelta = (
  legacy: Record<string, unknown>,
  current: Record<string, unknown>,
): {
  modified: Record<string, unknown>;
  deleted: Record<string, unknown>;
} => {
  const modified: Record<string, unknown> = {};
  const deleted: Record<string, unknown> = {};

  for (const [key, lValue] of Object.entries(legacy)) {
    if (!(key in current)) {
      deleted[key] = lValue;
    }
  }
  for (const [key, cValue] of Object.entries(current)) {
    if (!cValue) continue;
    if (equal(cValue, legacy[key])) continue;

    if (Array.isArray(cValue)) {
      modified[key] = cValue;
    } else if (typeof cValue === "object") {
      if (!(key in legacy) || Array.isArray(legacy[key])) {
        // legacy does not have this key, or
        // current is Object, but legacy is Array
        modified[key] = cValue;
      } else if (typeof legacy[key] === "object") {
        // both current and legacy are Object
        const localDiff = computeDelta(
          legacy[key] as Record<string, unknown>,
          cValue as Record<string, unknown>,
        );
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
  return { modified, deleted };
};
