import React from 'react';
import PropTypes from 'prop-types';

import './FamilyDetailContainer.css';

import FamilyDetail from '../../components/FamilyDetail';
import KinshipsTable from '../../components/KinshipsTable';
import KidsTable from '../../components/KidsTable';

const FamilyDetailContainer = ({ details }) => (
  <div className="family__detail">
    <h1 className="family__title">
      Família - {`${details.description}`.toUpperCase()}
    </h1>
    <FamilyDetail detail={details} />

    <div className="familly__kinships">
      <h2 className="family__title">Reponsáveis</h2>
      <KinshipsTable familyId={details.id} kinships={details.kinships} />
    </div>
    
    <div className="familly__kids">
      <h2 className="family__title">Crianças</h2>
      <KidsTable familyId={details.id} kids={details.kids} />
    </div>
  </div>
);

FamilyDetailContainer.propTypes = {
  details: PropTypes.shape({
    id: PropTypes.string.isRequired,
    description: PropTypes.string.isRequired,
    address: PropTypes.string.isRequired,
    phone_number: PropTypes.string.isRequired,
    cell_phone_number: PropTypes.string.isRequired,
    religion: PropTypes.string.isRequired,
    church_information: PropTypes.string.isRequired,
    total_family_members: PropTypes.number.isRequired,
    kinships: PropTypes.arrayOf(
      PropTypes.shape({
        id: PropTypes.string.isRequired,
        description: PropTypes.string.isRequired,
        person_name: PropTypes.string.isRequired,
      })
    ).isRequired,
    kids: PropTypes.arrayOf(
      PropTypes.shape({
        id: PropTypes.string.isRequired,
        name: PropTypes.string.isRequired,
        birth_date: PropTypes.string.isRequired,
        doing_catechesis: PropTypes.bool.isRequired,
        doing_confirmation_sacrament: PropTypes.bool.isRequired,
        doing_perse: PropTypes.bool.isRequired,
        done_catechesis: PropTypes.bool.isRequired,
        done_confirmation_sacrament: PropTypes.bool.isRequired,
        done_perse: PropTypes.bool.isRequired,
        is_baptized: PropTypes.bool.isRequired,
      })
    ).isRequired,
  }).isRequired,
};

export default FamilyDetailContainer;
