import { useState, useEffect } from "react/cjs/react.development";
import "./App.css";
import { ProductDisplay } from "./components/ProductDisplay";
import { ProductData } from "./data/ProductData";

function App() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    fetch("/api/react", {
      headers: {
        accepts: "application/json",
      },
    })
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);

  return (
    <div className="App">
      <h1>Godis</h1>
      {/* <ProductDisplay products={ProductData}></ProductDisplay> */}
      <ProductDisplay products={products}></ProductDisplay>
    </div>
  );
}

export default App;
