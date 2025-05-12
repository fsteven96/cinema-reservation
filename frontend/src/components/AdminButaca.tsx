import { useForm } from "react-hook-form";

export default function AdminButaca() {
  const { register, handleSubmit } = useForm();

  const onSubmit = (data) => {
    console.log(data);
  };

  return (
    <form onSubmit={handleSubmit(onSubmit)} className="p-4 bg-white rounded shadow w-full max-w-md mx-auto mt-4">
      <h2 className="text-xl mb-4 font-bold">Administrar Butacas</h2>
      <input {...register("roomId")} placeholder="Room ID" className="input input-bordered w-full mb-2" />
      <input {...register("date")} type="datetime-local" className="input input-bordered w-full mb-2" />
      <button type="submit" className="bg-blue-500 text-white px-4 py-2 rounded">Enviar</button>
    </form>
  );
}
