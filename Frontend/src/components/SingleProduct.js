import { ProductCard } from "./StyledComponents";

export const SingleProduct = (props) => {
  return (
    <ProductCard>
      <h2>{props.item.Name}</h2>
      <p>{props.item.Description}</p>
      <h3>{props.item.Price}</h3>
      <span>{props.item.Stock < 100 && "Få produkter i lager"}</span>
      <img src={`/img/${props.item.Id}.png`} alt="sten" />
    </ProductCard>
  );
};
