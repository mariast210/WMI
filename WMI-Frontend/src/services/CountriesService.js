import { apiRequest } from "../utils/apiRequest";

export const CountriesService = {
  getAll: async (filter) => {
    const response = await apiRequest.request({
      url: "/countries",
      method: "GET",
      params: filter,
    });

    return response;
  },
};
