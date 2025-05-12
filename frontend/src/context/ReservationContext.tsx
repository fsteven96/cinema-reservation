import { createContext, useContext, useState } from "react";

export const ReservationContext = createContext(null);

export const ReservationProvider = ({ children }) => {
  const [reservations, setReservations] = useState([]);

  const addReservation = (res) => setReservations((prev) => [...prev, res]);

  return (
    <ReservationContext.Provider value={{ reservations, addReservation }}>
      {children}
    </ReservationContext.Provider>
  );
};

export const useReservation = () => useContext(ReservationContext);