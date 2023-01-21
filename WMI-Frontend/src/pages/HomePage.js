import {
  DataGrid,
  getGridSingleSelectOperators,
  GridToolbar,
} from "@mui/x-data-grid";
import { useState, useEffect } from "react";
import { CarsService } from "../services/CarsService";
import { CountriesService } from "../services/CountriesService";
import dayjs from "dayjs";
import { filterModelToQuery, sortModelToQuery } from "../utils/queryUtils";

const DEFAULT_PAGE_SIZE = 10;
const DEFAULT_PAGE = 0;
const DEFAULT_PAGE_OPTIONS = [10, 25, 100];
const DEFAULT_SORT = [
  { field: "createdOn", sort: "asc" },
  { field: "wmi", sort: "asc" },
];

const HomePage = () => {
  const [countries, setCountries] = useState([]);
  const [cars, setCars] = useState([]);
  const [rowsCount, setRowsCount] = useState(0);
  const [page, setPage] = useState(DEFAULT_PAGE);
  const [pageSize, setPageSize] = useState(DEFAULT_PAGE_SIZE);
  const [query, setQuery] = useState({
    top: DEFAULT_PAGE_SIZE,
    skip: DEFAULT_PAGE,
    orderBy: sortModelToQuery(DEFAULT_SORT),
  });

  const searchColumns = ["country", "name", "vehicleType", "wmi"];

  const columns = [
    { field: "id", headerName: "Id", flex: 1, filterable: false },
    {
      field: "country",
      headerName: "Country",
      flex: 1,
      type: "singleSelect",
      valueOptions: countries,
      filterOperators: getGridSingleSelectOperators().filter(
        (operator) => operator.value === "is"
      ),
    },
    {
      field: "createdOn",
      headerName: "Created On",
      flex: 1,
      filterable: false,
      valueFormatter: (params) =>
        params?.value ? dayjs(params.value).format("YYYY-MM-DD") : "",
    },
    {
      field: "dateAvailableToPublic",
      headerName: "Date available to public",
      flex: 1,
      filterable: false,
      valueFormatter: (params) =>
        params?.value ? dayjs(params.value).format("YYYY-MM-DD") : "",
    },
    { field: "name", headerName: "Name", flex: 1, filterable: false },
    {
      field: "updatedOn",
      headerName: "Updated on",
      flex: 1,
      filterable: false,
      valueFormatter: (params) =>
        params?.value ? dayjs(params.value).format("YYYY-MM-DD") : "",
    },
    {
      field: "vehicleType",
      headerName: "Vehicle Type",
      flex: 1,
      filterable: false,
    },
    { field: "wmi", headerName: "WMI", flex: 1, filterable: false },
  ];

  useEffect(() => {
    handleGetCountries();
  }, []);

  useEffect(() => {
    handleGetCars();
  }, [query]);

  const handleGetCountries = async () => {
    const response = await CountriesService.getAll();
    if (response.data) {
      setCountries(response.data);
    }
  };

  const handleGetCars = async () => {
    const response = await CarsService.getAll(query);
    if (response.data) {
      setCars(response.data.data);
      setRowsCount(response.data.totalCount);
    }
  };

  const handleFilterModelChange = (filterModel) => {
    const filterQuery = filterModelToQuery(filterModel, searchColumns);
    setQuery({ ...query, filter: filterQuery });
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
      setQuery({ ...query, orderBy: sortModelToQuery(DEFAULT_SORT) });
    }
  };

  return (
    <div style={{ height: 800, width: "100%" }}>
      <DataGrid
        rows={cars}
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

export default HomePage;
