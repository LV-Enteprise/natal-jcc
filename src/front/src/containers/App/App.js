import React from 'react';
import { BrowserRouter as Router } from 'react-router-dom';

import './App.css';

import Navbar from '../../components/Navbar';
import Routes from '../../routes';

const App = () => (
  <Router>
    <Navbar />
    <Routes />
  </Router>
);

export default App;
