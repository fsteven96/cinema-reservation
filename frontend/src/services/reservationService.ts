import axios from "axios";

const API_URL = "http://localhost:5000/api/booking";

export const getBookingsByGenre = (genre, startDate, endDate) => {
  return axios.get(`${API_URL}/by-genre`, {
    params: { genre, startDate, endDate },
  });
};

export const getAvailableSeats = (roomId, date) => {
  return axios.get(`${API_URL}/available-seats`, {
    params: { roomId, date },
  });
};

export const getOccupiedSeats = (roomId, date) => {
  return axios.get(`${API_URL}/occupied-seats`, {
    params: { roomId, date },
  });
};