import React, { useState, useEffect } from 'react';

import Loading from '../../components/Loading';
import Families from '../../containers/Families';
import Urls from '../../shared/BaseUrls';

const FamiliesRoute = () => {
  const [families, setFamilies] = useState([]);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    const fetchFamilies = () => {
      setIsLoading(true);
      fetch(Urls.FAMILIES_ENDPOINT)
        .then((resp) => resp.json())
        .then((resp) => {
          setFamilies(resp);
        })
        .catch()
        .finally(() => {
          setIsLoading(false);
        });
    };

    fetchFamilies();
  }, []);

  return (
    <div className="families">
      {isLoading ? <Loading /> : <Families _families={families} />}
    </div>
  );
};

export default FamiliesRoute;
