// import { StrictMode } from 'react'
// import { createRoot } from 'react-dom/client'
// import './index.css'
// import App from './App.tsx'

// createRoot(document.getElementById('root')!).render(
//   <StrictMode>
//     <App />
//   </StrictMode>,
// )

import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import AppRouter from "./routes/AppRouter";
import { ReservationProvider } from "./context/ReservationContext";

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <ReservationProvider>
      <AppRouter />
    </ReservationProvider>
  </React.StrictMode>
);