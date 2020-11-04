import React from 'react';
import PropTypes from 'prop-types';

import './FamiliesTable.css';

import DetailButton from '../DetailButton';

const FamiliesTable = ({ families }) => (
  <div className="table__container">
    <table className="families__table">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>Descrição</th>
        </tr>
      </thead>
      <tbody>
        {families.map((family, index) => (
          <tr key={family.id}>
            <td>
              <DetailButton url={`families/${family.id}`} description="Ver mais detalhes" />
            </td>
            <td key={index}>{family.description}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

FamiliesTable.propTypes = {
  families: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.string.isRequired,
      description: PropTypes.string.isRequired,
    }).isRequired
  ).isRequired,
};

export default FamiliesTable;
