import { getUnixTime } from "date-fns";

export const convertBoolean = <T>(value: T): unknown => {
  if (typeof value === "boolean") return value ? 1 : 0;
  else if (Array.isArray(value)) {
    return value.map((val) => convertBoolean(val));
  } else if (value !== null && typeof value === "object") {
    return Object.fromEntries(
      Object.entries(value).map(([k, v]) => [k, convertBoolean(v)]),
    );
  } else return value;
};

export const convertDate = <T>(value: T): unknown => {
  if (value instanceof Date) return getUnixTime(value);
  else if (Array.isArray(value)) {
    return value.map((val) => convertDate(val));
  } else if (value !== null && typeof value === "object") {
    return Object.fromEntries(
      Object.entries(value).map(([k, v]) => [k, convertDate(v)]),
    );
  } else return value;
};
