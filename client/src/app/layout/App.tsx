import { Container } from '@mui/material';
import React from 'react';
import { Outlet } from 'react-router-dom';

const App: React.FC = () => (
  <Container>
    <Outlet />
  </Container>
);

export default App;
