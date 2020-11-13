import React from 'react';
import PropTypes from 'prop-types';

import './KinshipsTable.css';

import EditButton from '../EditButton';
import AddButton from '../AddButton';

const KinshipsTable = ({ familyId, kinships }) => (
  <div className="table__container">
    <table className="kinships__table">
      <thead>
        <tr>
          <th><AddButton url={`/`} /></th>
          <th>Descrição</th>
          <th>Nome</th>
        </tr>
      </thead>
      <tbody>
        {kinships.map((kinship) => (
          <tr key={kinship.id}>
            <td>
              <EditButton
                url={`${familyId}/kinships/${kinship.id}/edit`}
                description="Editar responsável"
              />
            </td>
            <td>{kinship.description}</td>
            <td>{kinship.person_name}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

KinshipsTable.propTypes = {
  familyId: PropTypes.string.isRequired,
  kinships: PropTypes.arrayOf(
    PropTypes.shape({
      id: PropTypes.string.isRequired,
      description: PropTypes.string.isRequired,
      person_name: PropTypes.string.isRequired,
    })
  ).isRequired,
};

export default KinshipsTable;
