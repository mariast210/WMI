import { DataGrid } from "@mui/x-data-grid";
import * as React from "react";
import data from "../honda_wmi.json";

const HomePage = () => {
  const columns = [
    { field: "Id", headerName: "Id", flex: 1, filterable: false },
    {
      field: "Country",
      headerName: "Country",
      flex: 1,
      type: "singleSelect",
      valueOptions: ["United Kingdom", "Spain", "Brazil"],
    },
    {
      field: "CreatedOn",
      headerName: "Created On",
      flex: 1,
      filterable: false,
    },
    {
      field: "DateAvailableToPublic",
      headerName: "Date available to public",
      flex: 1,
      filterable: false,
    },
    { field: "Name", headerName: "Name", flex: 1, filterable: false },
    {
      field: "UpdatedOn",
      headerName: "Updated on",
      flex: 1,
      filterable: false,
    },
    {
      field: "VehicleType",
      headerName: "Vehicle Type",
      flex: 1,
      filterable: false,
    },
    { field: "WMI", headerName: "WMI", flex: 1, filterable: false },
  ];

  return (
    <div style={{ height: 800, width: "100%" }}>
      <DataGrid
        rows={data}
        columns={columns}
        getRowId={(row) => row.Id}
        disableColumnSelector
      />
    </div>
  );
};

export default HomePage;
