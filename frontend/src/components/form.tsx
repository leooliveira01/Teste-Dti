import { zodResolver } from "@hookform/resolvers/zod";
import { useForm } from "react-hook-form";
import { z } from "zod";
import { format } from "date-fns";

import { Button } from "@/components/ui/button";
import {
  Form,
  FormControl,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from "@/components/ui/form";
import { Input } from "@/components/ui/input";
import {
  Popover,
  PopoverContent,
  PopoverTrigger,
} from "@/components/ui/popover";
import { CalendarIcon } from "lucide-react";
import { cn } from "@/lib/utils";
import { Calendar } from "@/components/ui/calendar";
import { FormValues } from "@/App";

const FormSchema = z.object({
  smallDogs: z.string({
    required_error: "Número de cachorros é obrigatório",
  }),
  bigDogs: z.string({
    required_error: "Número de cachorros é obrigatório",
  }),
  date: z.date({
    required_error: "Data é obrigatório",
  }),
});

type Props = {
  onSubmit: (data: FormValues) => void;
};

export function InputForm({ onSubmit }: Props) {
  const form = useForm<z.infer<typeof FormSchema>>({
    resolver: zodResolver(FormSchema),
  });

  // function onSubmit(data: z.infer<typeof FormSchema>) {
  //   console.log("teste");
  //   axios
  //     .post("http://localhost:3001/petshop", {
  //       data: data.date,
  //       qtePequenos: parseInt(data.smallDogs),
  //       qteGrandes: parseInt(data.bigDogs),
  //     })
  //     .then((response) => {
  //       setBetterPetshop(response.data);
  //     })
  //     .catch((error) => {
  //       setBetterPetshop({ melhorpetshop: "Erro", precoTotal: 0 });
  //     });
  // }

  return (
    <Form {...form}>
      <form onSubmit={form.handleSubmit(onSubmit)} className="w-2/3 space-y-6">
        <FormField
          control={form.control}
          name="date"
          render={({ field }) => (
            <FormItem className="flex flex-col">
              <FormLabel>Data do serviço</FormLabel>
              <Popover>
                <PopoverTrigger asChild>
                  <FormControl>
                    <Button
                      variant={"outline"}
                      className={cn(
                        "w-[240px] pl-3 text-left font-normal",
                        !field.value && "text-muted-foreground"
                      )}
                    >
                      {field.value ? (
                        format(field.value, "PPP")
                      ) : (
                        <span>Escolha uma data</span>
                      )}
                      <CalendarIcon className="ml-auto h-4 w-4 opacity-50" />
                    </Button>
                  </FormControl>
                </PopoverTrigger>
                <PopoverContent className="w-auto p-0" align="start">
                  <Calendar
                    mode="single"
                    selected={field.value}
                    onSelect={field.onChange}
                    disabled={(date) =>
                      date > new Date() || date < new Date("1900-01-01")
                    }
                    initialFocus
                  />
                </PopoverContent>
              </Popover>
              <FormMessage />
            </FormItem>
          )}
        />
        <FormField
          control={form.control}
          name="smallDogs"
          render={({ field }) => (
            <FormItem>
              <FormLabel>Número de cachorros pequenos</FormLabel>
              <FormControl>
                <Input placeholder="0" {...field} type="number" />
              </FormControl>
              <FormMessage />
            </FormItem>
          )}
        />
        <FormField
          control={form.control}
          name="bigDogs"
          render={({ field }) => (
            <FormItem>
              <FormLabel>Número de cachorros grandes</FormLabel>
              <FormControl>
                <Input placeholder="0" {...field} type="number" />
              </FormControl>
              <FormMessage />
            </FormItem>
          )}
        />
        <Button type="submit">Submit</Button>
      </form>
    </Form>
  );
}
