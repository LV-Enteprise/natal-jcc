import React from 'react';
import { Link } from 'react-router-dom';

import './Navbar.css';

const Navbar = () => (
  <header className="topbar">
    <div className="container">
      <div className="topbar__logo">
        <Link to="/" className="logo">
          <span>JCC</span>
        </Link>
      </div>

      <div className="topbar__group">
        <button className="topbar__icon">
          <Link to="/">
            <i className="fa fa-users"></i>
            <span>Famílias</span>
          </Link>
        </button>
      </div>
    </div>
  </header>
);

export default Navbar;
