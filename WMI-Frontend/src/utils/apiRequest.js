import axios from "axios";

const apiBaseUrl = process.env.REACT_APP_BASE_API_URL;

export const apiRequest = axios.create({
  baseURL: `${apiBaseUrl}/api`,
});

const errorHandler = (error) => {
  const statusCode = error.response?.status;

  if (statusCode && statusCode !== 401) {
    console.error(error);
  }

  return Promise.reject(error);
};

apiRequest.interceptors.response.use(undefined, (error) => {
  return errorHandler(error);
});
