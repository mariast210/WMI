export const filterModelToQuery = (filterModel, columns) => {
  const allQueries = [];

  const quickSearchQuery = quickSearchToQuery(filterModel, columns);
  if (quickSearchQuery) {
    allQueries.push(`(${quickSearchQuery})`);
  }

  const filterQuery = filtersToQuery(filterModel);
  if (filterQuery) {
    allQueries.push(`(${filterQuery})`);
  }
  return allQueries.join(" and ");
};

export const sortModelToQuery = (sortModel) => {
  const sort = [];
  sortModel?.forEach((x) => {
    sort.push(`${x.field} ${x.sort}`);
  });
  return sort.join(", ");
};

export const filtersToQuery = (filterModel) => {
  const filters = [];
  filterModel?.items?.forEach((x) => {
    if (x.value) {
      filters.push(`${x.columnField} eq '${x.value}'`);
    } else if (x.value === "Blank") {
      filters.push(`${x.columnField} eq null`);
    }
  });
  return `${filters.join(" and ")}`;
};

export const quickSearchToQuery = (filterModel, searchColumns) => {
  const quickFilter = filterModel.quickFilterValues[0];
  const filters = [];
  if (quickFilter) {
    searchColumns?.forEach((x) => {
      filters.push(`contains(toLower(${x}), toLower('${quickFilter}'))`);
    });
  }
  return `${filters.join(" or ")}`;
};
