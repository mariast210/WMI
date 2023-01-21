import { apiRequest } from "../utils/apiRequest";

export const CarsService = {
  getAll: async (filter) => {
    const response = await apiRequest.request({
      url: "/cars",
      method: "GET",
      params: filter,
    });

    return response;
  },
};
