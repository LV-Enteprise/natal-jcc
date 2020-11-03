import React from 'react';
import { Route, Switch, Redirect } from 'react-router-dom';

import FamiliesRoute from './FamiliesRoute';
import FamilyRoute from './FamilyRoute';

const Routes = () => (
  <Switch>
    <Route path='/' exact component={FamiliesRoute} />
    <Route path='/families/:familyId' exact component={FamilyRoute} />
    <Route path='*'>
      <Redirect to='/' />
    </Route>
  </Switch>
);

export default Routes;
