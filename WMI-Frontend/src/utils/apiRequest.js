import axios from "axios";

export const apiRequest = axios.create({
  baseURL: "https://localhost:5001/api",
});

const errorHandler = (error) => {
  const statusCode = error.response?.status;

  if (statusCode && statusCode !== 401) {
    //TODO use toast instead
    console.error(error);
  }

  return Promise.reject(error);
};

apiRequest.interceptors.response.use(undefined, (error) => {
  return errorHandler(error);
});
