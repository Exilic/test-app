import { SingleProduct } from "./SingleProduct";
import { ProductSection } from "./StyledComponents";

export const ProductDisplay = (props) => {
  const mapProducts = () => {
    return props.products.map((product) => <SingleProduct key={product.Id} item={product} />);
  };
  return <ProductSection>{mapProducts()}</ProductSection>;
};
