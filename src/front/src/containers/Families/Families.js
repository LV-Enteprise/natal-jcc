import React from 'react';

import FamiliesTable from '../../components/FamiliesTable'

const Families = ({ _families }) => (
  <div className="container">
    <h1>Famílias</h1>
    <FamiliesTable families={_families} />
  </div>
);

export default Families;
