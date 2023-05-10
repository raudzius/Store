// @ts-ignore:next-line
import React from 'react';
import { createBrowserRouter } from 'react-router-dom';
import App from '../layout/App';

const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [],
  },
]);

export default router;
