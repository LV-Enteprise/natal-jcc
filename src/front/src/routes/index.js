import React from 'react';
import { Route, Switch } from 'react-router-dom';

import FamiliesRoute from './FamiliesRoute';
import Kids from '../pages/Kids';
import Families from '../pages/Families';

const Routes = () => (
  <Switch>
    <Route path='/' exact component={FamiliesRoute} />
    <Route path='/kids' component={Kids} />
    <Route path='/families' component={Families} />
  </Switch>
);

export default Routes;
