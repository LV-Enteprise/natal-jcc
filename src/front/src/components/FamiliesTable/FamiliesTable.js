import React from 'react';

import './FamiliesTable.css';

const FamiliesTable = ({ families }) => (
  <div className="table__container">
    <table>
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
              <button className="button--edit">
                <i className="fas fa-edit"></i>
              </button>
            </td>
            <td key={index}>{family.description}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

export default FamiliesTable;
