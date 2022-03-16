import styled from "styled-components";

export const ProductSection = styled.section`
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(160px, 1fr));
`;

export const ProductCard = styled.article`
  border: 1px solid rgb(53, 58, 113, 0.2);
  background-color: white;
  display: flex;
  flex-direction: column;
  position: relative;
  & img {
    order: -1;
  }
  & span {
    color: red;
  }
`;
