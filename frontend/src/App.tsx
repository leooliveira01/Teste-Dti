import { CardForm } from "@/components/cardForm";
import axios from "axios";


export type FormValues = {
  smallDogs: string;
  bigDogs: string;
  date: Date;
};

function App() {
  

  const onSubmit = async (data: FormValues) => {
    try {
      const response = await axios.post(`${import.meta.env.VITE_API_URL}/petshop`, {
        data: data.date,
        qtdPequenos: parseInt(data.smallDogs),
        qtdGrandes: parseInt(data.bigDogs),
      });
      alert(" O Melhor PetShop a ser utilizado é: " + response.data.melhorPetshop + " \nPreço Total: " + response.data.precoTotal)
    } catch (error) {
      console.log(error);
    }
  }
  return (
    <div className="flex items-center justify-around w-full h-screen">
      
        <CardForm onSubmit={onSubmit} />
    
    </div>
  );
}

export default App;
