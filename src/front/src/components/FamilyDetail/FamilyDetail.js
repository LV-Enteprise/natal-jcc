import React from 'react';
import PropTypes from 'prop-types';

import './FamilyDetail.css';

const FamilyDetail = ({ detail }) => (
  <>
    <p>
      <span className="family__topic">Endereço: </span>
      <span>{detail.address}</span>
    </p>
    <p>
      <span className="family__topic">Telefone: </span>
      <span>{detail.phone_number}</span>
    </p>
    <p>
      <span className="family__topic">Celular: </span>
      <span>{detail.cell_phone_number}</span>
    </p>
    <p>
      <span className="family__topic">Total de membros: </span>
      <span>{detail.total_family_members}</span>
    </p>
    <p>
      <span className="family__topic">Religião: </span>
      <span>{detail.religion}</span>
    </p>
    <p>
      <span className="family__topic">Igreja que participa: </span>
      <span>{detail.church_information}</span>
    </p>
  </>
);

FamilyDetail.propTypes = {
  detail: PropTypes.shape({
    description: PropTypes.string.isRequired,
    address: PropTypes.string.isRequired,
    phone_number: PropTypes.string.isRequired,
    cell_phone_number: PropTypes.string.isRequired,
    religion: PropTypes.string.isRequired,
    church_information: PropTypes.string.isRequired,
    total_family_members: PropTypes.number.isRequired,
  }).isRequired,
};

export default FamilyDetail;
