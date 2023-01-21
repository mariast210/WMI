import {
  DataGrid,
  getGridSingleSelectOperators,
  GridToolbar,
} from "@mui/x-data-grid";
import { useState, useEffect } from "react";
import { CarsService } from "../services/CarsService";
import { CountriesService } from "../services/CountriesService";
import dayjs from "dayjs";

const HomePage = () => {
  const [countries, setCountries] = useState([]);
  const [cars, setCars] = useState([]);
  const [rowsCount, setRowsCount] = useState(0);
  const [filter, setFilter] = useState({});

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
    handleGetCars();
  }, []);

  const handleGetCountries = async () => {
    const response = await CountriesService.getAll();
    if (response.data) {
      setCountries(response.data);
    }
  };

  const handleGetCars = async () => {
    const response = await CarsService.getAll();
    if (response.data) {
      setCars(response.data.data);
      setRowsCount(response.data.totalCount);
    }
  };

  const handleFilterModelChange = (filterModel) => {
    setFilter({ filterModel: { ...filterModel } });
    console.log(filterModel);
  };

  return (
    <div style={{ height: 800, width: "100%" }}>
      <DataGrid
        rows={cars}
        columns={columns}
        filterMode="server"
        onFilterModelChange={handleFilterModelChange}
        //loading={true}
        disableColumnSelector
        disableDensitySelector
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
