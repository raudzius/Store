import React from 'react';
import { Container, CssBaseline } from '@mui/material';
import { Outlet } from 'react-router-dom';
import Header from './Header';

const App: React.FC = () => (
  <>
    <CssBaseline />
    <Header />
    <Container>
      <Outlet />
    </Container>
  </>
);

export default App;
