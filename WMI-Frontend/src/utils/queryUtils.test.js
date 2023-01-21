import {
  filterModelToQuery,
  sortModelToQuery,
  filtersToQuery,
  quickSearchToQuery,
} from "../utils/queryUtils";

describe("Sort Model To Query", () => {
  test("it should convert sort model to odata query string", () => {
    const input = [
      { field: "createdOn", sort: "asc" },
      { field: "wmi", sort: "asc" },
    ];

    const output = "createdOn asc, wmi asc";

    expect(sortModelToQuery(input)).toEqual(output);
  });
});

describe("Filters To Query", () => {
  test("it should convert filter models to odata query string", () => {
    const input = {
      items: [
        { columnField: "country", value: "Blank" },
        { columnField: "name", value: "Ford" },
      ],
    };

    const output = "country eq null and name eq 'Ford'";

    expect(filtersToQuery(input)).toEqual(output);
  });
});

describe("Quick Search To Query", () => {
  test("it should convert quick search model to odata query string", () => {
    const input = { quickFilterValues: ["test"] };

    const output =
      "contains(toLower(wmi), toLower('test')) or contains(toLower(country), toLower('test'))";

    expect(quickSearchToQuery(input, ["wmi", "country"])).toEqual(output);
  });
});

describe("Filter Model To Query", () => {
  test("it should convert filter models to odata query string", () => {
    const input = {
      quickFilterValues: ["test"],
      items: [
        { columnField: "country", value: "Blank" },
        { columnField: "name", value: "Ford" },
      ],
    };

    const output =
      "(contains(toLower(wmi), toLower('test')) or contains(toLower(country), toLower('test'))) and (country eq null and name eq 'Ford')";

    expect(filterModelToQuery(input, ["wmi", "country"])).toEqual(output);
  });
});
