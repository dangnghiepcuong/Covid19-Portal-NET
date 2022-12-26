$(document).ready(function () {

    // LOAD FRONT END DATA
    menu_title = '<a href="/ORG/ManageOrg">Quản lý đơn vị tiêm chủng</a>'
    $('#function-navigation-bar-title').html(menu_title)

    homepage = '<a href="/Home">Trang chủ</a>'
    $('#homepage-path').html(homepage)

    subpage = '<a href="/ORG/ManageOrg">Đơn vị tiêm chủng</a>'
    $('#subpage-path').html(subpage)

    selected_function = '<a href="/ORG/ManageOrg">Quản lý đơn vị tiêm chủng</a>'
    $('#selected-function-path').html(selected_function)

    $('#function-menu-title').text('Đơn vị tiêm chủng')

    menu = '<br><a href="/ORG/ManageOrg"><li>Quản lý đơn vị</li></a>'
    menu += '<br><a href="/ORG/ProvideOrgAcc"><li>Cấp tài khoản đơn vị</li></a>'

    $('#function-menu-list').find('ul').html(menu)
    // END LOAD FRONT END DATA

    LoadOrg()

    $('#btn-filter-org').click(function () {
        LoadOrg()
    })

    function LoadOrg() {
        province = $('#select-province').find('option:selected').text()
        district = $('#select-district').find('option:selected').text()
        town = $('#select-town').find('option:selected').text()

        $.ajax({
            cache: false,
            url: '/ORG/LoadOrg',
            type: 'POST',
            data: { province: province, district: district, town: town },
            success: function (data) {
                if (data.substring(0, 3) == 'ORA') {    //EXCEPTION
                    alert(data)
                    return
                }
                $('#list-org').html(data)
            },
            error: function (error) {
            }
        })
    }
})

