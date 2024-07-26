import { defineStore } from 'pinia'
import type { Navigation } from 'src/core/types'
import { ref } from 'vue'

export default defineStore('sidebar-navigation', () => {
  const defaultMenu = ref<Navigation[]>([
    {
      url: '/',
      icon: 'dashboard',
      title: 'Dashboard',
    },
    {
      url: '/profile',
      icon: 'person',
      title: 'Profile',
    },
    {
      url: '/timesheet',
      icon: 'punch_clock',
      title: 'Timesheet',
    },
    {
      url: '/leaves',
      icon: 'view_column',
      title: 'Leaves',
    },
    {
      url: '/payslips',
      icon: 'credit_card',
      title: 'Payslips',
    },
  ])

  const adminMenu = ref<Navigation[]>([
    {
      url: '/administration',
      icon: 'home',
      title: 'Dashboard',
    },
    {
      url: '/administration/employees',
      icon: 'people',
      title: 'Employees',
    },
    {
      url: '/administration/requests',
      icon: 'list_alt',
      title: 'Requests',
    },
  ])

  return { defaultMenu, adminMenu }
})
