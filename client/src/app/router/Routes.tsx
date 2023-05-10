// @ts-ignore:next-line
import React from 'react';
import { createBrowserRouter } from 'react-router-dom';
import App from '../layout/App';
import Catalog from '../../features/catalog/Catalog';

const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [{ path: 'catalog', element: <Catalog /> }],
  },
]);

export default router;
