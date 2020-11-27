import React from 'react';
//import PropTypes from 'prop-types';

import './FamilyAddContainer.css';

const FamilyAddContainer = () => (
  <div className="family__add">
    <form>
      <label>
        Nome:
        <input type="text" name="name" />
      </label>
      <input type="submit" value="Enviar" />
    </form>
  </div>
);

export default FamilyAddContainer;