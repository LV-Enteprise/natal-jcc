import React from 'react';
import PropTypes from 'prop-types';

import './KidsTable.css';

import EditButton from '../EditButton';
import DetailButton from '../DetailButton';

const KidsTable = ({ familyId, kids }) => (
  <div className="table__container">
    <table className="kids__table">
      <thead>
        <tr>
          <th>&nbsp;</th>
          <th>Nome</th>
        </tr>
      </thead>
      <tbody>
        {kids.map((kid) => (
          <tr key={kid.id}>
            <td className="actions__column">
              <DetailButton
                id={kid.id}
                url={`${familyId}/kids/${kid.id}`}
                description="Ver mais detalhes"
              />
              <EditButton
                url={`${familyId}/kids/${kid.id}/edit`}
                description="Editar criança"
              />
            </td>
            <td>{kid.name}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

KidsTable.propTypes = {
  familyId: PropTypes.string.isRequired,
  kids: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.string.isRequired,
      name: PropTypes.string.isRequired,
    })
  ).isRequired,
};

export default KidsTable;
