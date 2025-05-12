import { useReservation } from "../context/ReservationContext";

export default function ReservationList() {
  const { reservations } = useReservation();

  return (
    <div className="p-4">
      <h2 className="text-xl font-bold mb-4">Lista de Reservas</h2>
      <ul className="space-y-2">
        {reservations.map((res, index) => (
          <li key={index} className="p-2 border rounded shadow">
            {JSON.stringify(res)}
          </li>
        ))}
      </ul>
    </div>
  );
}