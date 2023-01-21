import { getGridSingleSelectOperators } from "@mui/x-data-grid";
import dayjs from "dayjs";
import { useEffect, useState } from "react";
import { Table } from "../components/Table";
import { CarsService } from "../services/CarsService";
import { CountriesService } from "../services/CountriesService";

const DEFAULT_SORT = [
  { field: "createdOn", sort: "asc" },
  { field: "wmi", sort: "asc" },
];

const HomePage = () => {
  const [countries, setCountries] = useState([]);

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

  const handleGetCountries = async () => {
    const response = await CountriesService.getAll();
    if (response.data) {
      setCountries(response.data);
    }
  };

  return (
    <Table
      columns={columns}
      searchColumns={searchColumns}
      getDataFunc={CarsService.getAll}
      defaultSort={DEFAULT_SORT}
    />
  );
};

export default HomePage;
