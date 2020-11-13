import React from 'react';
import PropTypes from 'prop-types';

import { Link } from 'react-router-dom';

import './AddButton.css';

const AddButton = ({ url, description }) => (
  <Link
    to={url}
    className="add__button"
    title={description}
  >
    <i className="far fa-plus-square"></i>
  </Link>
);

AddButton.propTypes = {
  url: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
};

export default AddButton;