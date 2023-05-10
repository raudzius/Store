import { Grid } from '@mui/material';
import React from 'react';
import ProductCard from './ProductCard';

type Props = {
  products: Product[];
};

const ProductList: React.FC<Props> = ({ products }) => (
  <Grid container spacing={4}>
    {products.map((product) => (
      <Grid key={product.id} item xs={3}>
        <ProductCard product={product} />
      </Grid>
    ))}
  </Grid>
);

export default ProductList;
