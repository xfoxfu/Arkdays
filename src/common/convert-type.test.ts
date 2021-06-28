import { convertBoolean, convertDate } from "./convert-type";
import test from "ava";
import { getUnixTime, parseISO } from "date-fns";

test("convertBoolean primitive types", (t) => {
  t.deepEqual(convertBoolean(null), null);
  t.deepEqual(convertBoolean(undefined), undefined);
  t.deepEqual(convertBoolean(1), 1);
  t.deepEqual(convertBoolean(0), 0);
  t.deepEqual(convertBoolean(100), 100);
  t.deepEqual(convertBoolean(""), "");
  t.deepEqual(convertBoolean("Hello world!"), "Hello world!");
});

test("convertBoolean booleans", (t) => {
  t.deepEqual(convertBoolean(true), 1);
  t.deepEqual(convertBoolean(false), 0);
});

test("convertBoolean array and object", (t) => {
  t.deepEqual(convertBoolean([1, true, "123", false]), [1, 1, "123", 0]);
  t.deepEqual(convertBoolean({ foo: true, bar: { nested: false } }), {
    foo: 1,
    bar: { nested: 0 },
  });
});

test("convertDate primitive types", (t) => {
  t.deepEqual(convertDate(null), null);
  t.deepEqual(convertDate(undefined), undefined);
  t.deepEqual(convertDate(1), 1);
  t.deepEqual(convertDate(0), 0);
  t.deepEqual(convertDate(100), 100);
  t.deepEqual(convertDate(""), "");
  t.deepEqual(convertDate("Hello world!"), "Hello world!");
  t.deepEqual(convertDate(true), true);
  t.deepEqual(convertDate(false), false);
});

test("convertDate Dates", (t) => {
  t.deepEqual(convertDate(new Date()), getUnixTime(new Date()));
  t.deepEqual(
    convertDate(new Date(2008, 8, 8, 12, 30, 0)),
    getUnixTime(new Date(2008, 8, 8, 12, 30, 0)),
  );
});

test("convertDate array and object", (t) => {
  t.deepEqual(
    convertDate([
      1,
      parseISO("2019-12-31T08:00:00Z"),
      "123",
      parseISO("2019-12-30T08:00:00Z"),
    ]),
    [
      1,
      getUnixTime(parseISO("2019-12-31T08:00:00Z")),
      "123",
      getUnixTime(parseISO("2019-12-30T08:00:00Z")),
    ],
  );
  t.deepEqual(
    convertDate({
      foo: parseISO("2019-12-31T08:00:00Z"),
      bar: { nested: parseISO("2019-12-30T08:00:00Z") },
    }),
    {
      foo: getUnixTime(parseISO("2019-12-31T08:00:00Z")),
      bar: { nested: getUnixTime(parseISO("2019-12-30T08:00:00Z")) },
    },
  );
});
