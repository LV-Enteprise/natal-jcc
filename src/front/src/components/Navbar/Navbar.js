import React from 'react';
import { Link } from 'react-router-dom';

import { ReactComponent as LogoSvg } from '../../assets/img/instagram-logo.svg';

import './Navbar.css';

const Navbar = () => (
  <header className="topbar">
    <div className="container">
      <div className="topbar__logo">
        <Link to="/">
          <LogoSvg />
        </Link>
      </div>

      <div className="topbar__group">
        <button className="topbar__icon">
          <Link to="/users">
            <i className="fa fa-users"></i>
            <span>Famílias</span>
          </Link>
        </button>
      </div>
    </div>
  </header>
);

export default Navbar;
