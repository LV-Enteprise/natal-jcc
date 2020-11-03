import React from 'react';
import PropTypes from 'prop-types';

import { Link } from 'react-router-dom';

import './DetailButton.css';

const DetailButton = ({ url, description }) => (
  <Link
    to={url}
    className="detail__button"
    title={description}
  >
    <i className="fas fa-window-restore"></i>
  </Link>
);

DetailButton.propTypes = {
  url: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
};

export default DetailButton;
