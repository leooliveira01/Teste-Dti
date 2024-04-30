import React from "react";
import {
  Card,
  CardContent,
  CardDescription,
  CardHeader,
  CardTitle,
} from "@/components/ui/card";
import { InputForm } from "./form";
import { FormValues } from "@/App";

type Props = {
  onSubmit: (data: FormValues) => void;
};

export const CardForm = React.forwardRef((props: Props) => {
  return (
    <Card className="w-2/3 ">
      <CardHeader>
        <CardTitle>Encontre o melhor petshop para você!</CardTitle>
        <CardDescription>
          Insira a data que você deseja e a quantidade de cachorros que você for
          levar
        </CardDescription>
      </CardHeader>
      <CardContent>
        <InputForm onSubmit={props.onSubmit}/>
      </CardContent>
    </Card>
  );
});
