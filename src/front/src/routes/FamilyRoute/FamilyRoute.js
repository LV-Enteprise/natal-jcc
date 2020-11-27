import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';

import Loading from '../../components/Loading';
import Urls from '../../shared/BaseUrls';

import FamilyDetailContainer from '../../containers/FamilyDetailContainer';

const FamiliesRoute = () => {
  const { familyId } = useParams();
  const [family, setFamily] = useState(null);

  useEffect(() => {
    const fetchFamily = () => {
      fetch(`${Urls.FAMILIES_ENDPOINT}/${familyId}`)
        .then((resp) => resp.json())
        .then((resp) => {
          setFamily(resp);
        })
        .catch(error => {
          console.error(error);
          setFamily(null);
        });
    };

    fetchFamily();
  }, [familyId]);

  return (
    <div className="container">
      {family ? <FamilyDetailContainer details={family} /> : <Loading />}
    </div>
  );
};

export default FamiliesRoute;
