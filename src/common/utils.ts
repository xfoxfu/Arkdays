import { addHours, parseJSON, set, startOfDay } from "date-fns";

export const maybeJsonDate = (value: Date | number): Date =>
  value instanceof Date ? value : parseJSON(value);

export const getDayBound = (): Date =>
  set(new Date(), {
    hours: 4,
    minutes: 0,
    seconds: 0,
    milliseconds: 0,
  });
