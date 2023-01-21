import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import React, { useState, useEffect } from "react";
import { filterModelToQuery, sortModelToQuery } from "../utils/queryUtils";

const DEFAULT_PAGE_SIZE = 10;
const DEFAULT_PAGE = 0;
const DEFAULT_PAGE_OPTIONS = [10, 25, 100];

export const Table = ({ getDataFunc, columns, searchColumns, defaultSort }) => {
  const [data, setData] = useState([]);
  const [rowsCount, setRowsCount] = useState(0);
  const [page, setPage] = useState(DEFAULT_PAGE);
  const [pageSize, setPageSize] = useState(DEFAULT_PAGE_SIZE);
  const [query, setQuery] = useState({
    top: DEFAULT_PAGE_SIZE,
    skip: DEFAULT_PAGE,
    orderBy: sortModelToQuery(defaultSort),
  });

  useEffect(() => {
    (async () => {
      const response = await getDataFunc(query);
      if (response.data) {
        setData(response.data.data);
        setRowsCount(response.data.totalCount);
      }
    })();
  }, [query, getDataFunc]);

  const handleFilterModelChange = (filterModel) => {
    const filterQuery = filterModelToQuery(filterModel, searchColumns);
    if (filterQuery) {
      setQuery({ ...query, filter: filterQuery });
    } else {
      setQuery({ ...query, filter: null });
    }
  };

  const handlePageChange = (newPage) => {
    setPage(newPage);
    setQuery({ ...query, skip: newPage * pageSize });
  };

  const handlePageSizeChange = (newPageSize) => {
    setPageSize(newPageSize);
    setQuery({ ...query, top: newPageSize });
  };

  const handleSortModelChange = (sortModel) => {
    const sortQuery = sortModelToQuery(sortModel);
    if (sortQuery) {
      setQuery({ ...query, orderBy: sortModelToQuery(sortModel) });
    } else {
      setQuery({ ...query, orderBy: sortModelToQuery(defaultSort) });
    }
  };

  return (
    <div style={{ height: 800, width: "100%" }}>
      <DataGrid
        rows={data}
        rowCount={rowsCount}
        columns={columns}
        filterMode="server"
        paginationMode="server"
        sortingMode="server"
        onSortModelChange={handleSortModelChange}
        onFilterModelChange={handleFilterModelChange}
        rowsPerPageOptions={DEFAULT_PAGE_OPTIONS}
        //loading={true}
        disableColumnSelector
        disableDensitySelector
        page={page}
        pageSize={pageSize}
        onPageChange={handlePageChange}
        onPageSizeChange={handlePageSizeChange}
        components={{ Toolbar: GridToolbar }}
        componentsProps={{
          toolbar: {
            showQuickFilter: true,
            quickFilterProps: { debounceMs: 500 },
          },
        }}
      />
    </div>
  );
};
