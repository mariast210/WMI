FROM node:16-alpine AS build

ARG REACT_APP_BASE_API_URL
ENV REACT_APP_BASE_API_URL=$REACT_APP_BASE_API_URL

WORKDIR /usr/src/app

COPY package*.json ./

RUN npm ci

COPY . .

RUN npm run build

FROM nginx:alpine AS target

COPY --from=build /usr/src/app/build/ /usr/share/nginx/html