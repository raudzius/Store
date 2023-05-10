import React, { useState } from 'react';
import ProductList from './ProductList';
import agent from '../../app/api/agent';

const Catalog: React.FC = () => {
  const [products, setProducts] = useState<Product[]>([]);

  agent.Catalog.list().then((productsData) => setProducts(productsData));

  return <ProductList products={products} />;
};

export default Catalog;
