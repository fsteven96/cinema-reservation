import { BrowserRouter, Routes, Route } from "react-router-dom";
import AdminButaca from "../components/AdminButaca";
import AdminCartelera from "../components/AdminCartelera";
import ReservationList from "../components/ReservationList";

export default function AppRouter() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<ReservationList />} />
        <Route path="/butacas" element={<AdminButaca />} />
        <Route path="/cartelera" element={<AdminCartelera />} />
      </Routes>
    </BrowserRouter>
  );
}
