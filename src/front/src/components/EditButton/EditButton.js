import React from 'react';
import PropTypes from 'prop-types';

import { Link } from 'react-router-dom';

import './EditButton.css';

const EditButton = ({ url, description }) => (
  <Link
    to={url}
    className="edit__button"
    title={description}
  >
    <i className="fas fa-edit"></i>
  </Link>
);

EditButton.propTypes = {
  url: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
};

export default EditButton;
