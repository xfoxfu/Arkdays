import { computeDelta } from "./diff";
import test from "ava";

test("diff equals", (t) => {
  t.deepEqual(computeDelta({}, {}), { modified: {}, deleted: {} });
  t.deepEqual(computeDelta({ a: 1 }, { a: 1 }), { modified: {}, deleted: {} });
  t.deepEqual(
    computeDelta(
      { a: { b: 1 }, c: "string", d: [1, 2, 5] },
      { a: { b: 1 }, c: "string", d: [1, 2, 5] },
    ),
    { modified: {}, deleted: {} },
  );
});

test("duff boolean", (t) => {
  t.deepEqual(computeDelta({ f: false }, { f: true }), {
    modified: { f: true },
    deleted: {},
  });
  t.deepEqual(computeDelta({ f: true }, { f: false }), {
    modified: { f: false },
    deleted: {},
  });
});

test("diff array", (t) => {
  t.deepEqual(computeDelta({ a: [1, 2, 3, 4] }, { a: [] }), {
    modified: { a: [] },
    deleted: {},
  });
  t.deepEqual(computeDelta({ a: [1, 2, 3, 4] }, { a: [2, 3, 4] }), {
    modified: { a: [2, 3, 4] },
    deleted: {},
  });
  t.deepEqual(computeDelta({ a: { b: [1, 2, 3, 4] } }, { a: [2, 3, 4] }), {
    modified: { a: [2, 3, 4] },
    deleted: {},
  });
  t.deepEqual(computeDelta({ a: "string" }, { a: [2, 3, 4] }), {
    modified: { a: [2, 3, 4] },
    deleted: {},
  });
  t.deepEqual(computeDelta({ a: null }, { a: [2, 3, 4] }), {
    modified: { a: [2, 3, 4] },
    deleted: {},
  });
  t.deepEqual(computeDelta({ a: [{ b: 1 }] }, { a: [{ b: 1, c: 2 }] }), {
    modified: { a: [{ b: 1, c: 2 }] },
    deleted: {},
  });
});

test("diff object", (t) => {
  t.deepEqual(computeDelta({ a: { b: 1 } }, { a: { b: 1, c: 2 } }), {
    modified: { a: { c: 2 } },
    deleted: {},
  });
  t.deepEqual(
    computeDelta({ a: { b: 1, d: { e: 2 } } }, { a: { b: 1, c: 2 } }),
    {
      modified: { a: { c: 2 } },
      deleted: { a: { d: { e: 2 } } },
    },
  );
});
