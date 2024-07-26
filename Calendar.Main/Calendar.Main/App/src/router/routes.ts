import { type RouteRecordRaw } from 'vue-router'

export const routes: RouteRecordRaw[] = [
  {
    path: '/:pathMatch(.*)*',
    component: () => import('src/pages/404-page.vue'),
  },
  {
    path: '/',
    component: () => import('src/layouts/main-layout.vue'),
    children: [
      {
        path: '',
        component: () => import('src/pages/index-page.vue'),
      },
      {
        path: 'profile',
        component: () => import('src/pages/profile/index-page.vue'),
      },
      {
        path: 'timesheet',
        component: () => import('src/pages/timesheet/index-page.vue'),
      },
      {
        path: 'leaves',
        component: () => import('src/pages/leaves/index-page.vue'),
      },
      {
        path: 'payslips',
        component: () => import('src/pages/payslips/index-page.vue'),
      },
    ],
  },
  {
    path: '/administration',
    component: () => import('src/layouts/main-layout.vue'),
    children: [
      {
        path: '',
        component: () =>
          import('src/pages/administration/dashboard/index-page.vue'),
      },
      {
        path: 'employees',
        component: () =>
          import('src/pages/administration/employees/index-page.vue'),
      },
      {
        path: 'requests',
        component: () =>
          import('src/pages/administration/requests/index-page.vue'),
      },
    ],
  },
]
