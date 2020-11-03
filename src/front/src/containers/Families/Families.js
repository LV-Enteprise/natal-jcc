import React from 'react';
import PropTypes from 'prop-types';

import FamiliesTable from '../../components/FamiliesTable';

const Families = ({ _families }) => (
  <div className="container">
    <h1>Famílias</h1>
    <FamiliesTable families={_families} />
  </div>
);

Families.propTypes = {
  _families: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.string.isRequired,
      description: PropTypes.string.isRequired,
    }).isRequired
  ).isRequired,
};

export default Families;
