import React from 'react';
import './App.css';
import Navbar from './components/Navbar';
import { BrowserRouter as Router, Switch, Route} from "react-router-dom";
import Home from './pages/Home';
import Kids from './pages/Kids';
import Families from './pages/Families';

function App() {
  return (
    <>
      <Router>
        <Navbar />
        <Switch>
          <Route path='/' exact component={Home} />
          <Route path='/kids' component={Kids} />
          <Route path='/families' component={Families} />
        </Switch>
      </Router>
    </>
  );
}

export default App;
